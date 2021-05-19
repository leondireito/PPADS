import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Member } from '../_models/member';
import { of, pipe } from 'rxjs';
import { map, take } from 'rxjs/operators';
import { PaginatedResult } from '../_models/pagination';
import { UserParams } from '../_models/userParams';
import { AccountService } from './account.service';
import { User } from '../_models/user';
import { getPaginatedResult, getPaginationHeaders } from './paginationHelper';
import { Serie } from '../_models/serie';
import { Filme } from '../_models/filme';
import { Livro } from '../_models/livro';
import { Midia } from '../_models/midia';

@Injectable({
  providedIn: 'root'
})

export class MidiaService {
  baseUrl = environment.apiUrl;
  members: Member[] = [];
  memberCache = new Map();
  user: User;
  userParams: UserParams;
  serie: Serie;
  filme:Filme;
  livro:Livro;
  midia:Midia;

  constructor(private http: HttpClient, private accountService: AccountService) {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => {
      this.user = user;
      this.userParams = new UserParams(user);
    })
  }

  setSerie(serie: Serie) {

    serie.username = this.user.username;
    serie.tipo = 1;

    return this.http.post(this.baseUrl + 'midia/addserie', serie).pipe(
      map(() => {
       this.serie = serie;
      })
    )
  }

  setFilme(filme: Filme) {

    filme.username = this.user.username;
    filme.tipo = 0;

    return this.http.post(this.baseUrl + 'midia/addfilme', filme).pipe(
      map(() => {
       this.filme = filme;
      })
    )
  }

  
  setLivro(livro: Livro) {

    livro.username = this.user.username;
    livro.tipo = 2;

    return this.http.post(this.baseUrl + 'midia/addlivro', livro).pipe(
      map(() => {
       this.livro = livro;
      })
    )
  }

  getUserParams() {
    return this.userParams;
  }

  setUserParams(params: UserParams) {
    this.userParams = params;
  }

  resetUserParams() {
    this.userParams = new UserParams(this.user);
    return this.userParams;
  }

  getMidias(userParams: UserParams) {

    console.log("aqui");

   
    let params = getPaginationHeaders(userParams.pageNumber, userParams.pageSize);

    
    params = params.append('username', userParams.username);
    params = params.append('orderBy', userParams.orderBy);

    return getPaginatedResult<Midia[]>(this.baseUrl + 'midia/getmidias', params, this.http)
      .pipe(map(response => {
        this.memberCache.set(Object.values(userParams).join('-'), response);
        return response;
      }))
  }

  addLike(username: string) {
    return this.http.post(this.baseUrl + 'midia/likes' + username, {})
  }

}