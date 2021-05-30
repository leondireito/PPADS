import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AccountService } from '../_services/account.service';
import { Avaliacao } from '../_models/avaliacao';
import { ToastrService } from 'ngx-toastr';
import { MidiaService } from '../_services/midia.service';
import { take } from 'rxjs/operators';
import { User } from '../_models/user';
import { TabDirective, TabsetComponent } from 'ngx-bootstrap/tabs';
import { RelacionamentoService } from '../_services/relacionamento.service';
import { Relacionamento } from '../_models/relacionamento';
import {ActivatedRoute, Router} from '@angular/router';
import { AvaliaLike } from '../_models/avaliaLike';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  avaliacaoList: Avaliacao [];
  user: User;
  convitesList: Relacionamento[];
  invitesList: Relacionamento[];
  relationamentos: Relacionamento[];
  userLikes:AvaliaLike[];

  constructor(public accountService:AccountService, private route: ActivatedRoute,private router: Router,
    private relacionamentoService: RelacionamentoService,private midiaService: MidiaService
    ,private toastr: ToastrService) {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
   this.router.routeReuseStrategy.shouldReuseRoute = () => false;

   }

  ngOnInit(): void {


   this. getAvaliacoes();
   this.getRelacionamentos();
   this.getConvites();
   this.getInvites();
   this.getAvaliaLikes();


 
  }

  getAvaliacoes(){
    
    this.midiaService.getAvaliacoesMembro(this.user.username).subscribe(response => {
      this.avaliacaoList = response;
     
    })
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }

  getConvites(){
    this.relacionamentoService.listaConvites(this.user.username).subscribe(response => {
      this.convitesList = response;
    })
  }

  getInvites(){
    this.relacionamentoService.listInvites(this.user.username).subscribe(response => {
      this.invitesList = response;
    })
  }

  getRelacionamentos(){
    this.relacionamentoService.listRelacionamentos(this.user.username).subscribe(response => {
      
      this.relationamentos = response;

      this.relationamentos.forEach(rela => {
        

        
      });

    })
  }

  getAvaliaLikes(){
    this.midiaService.getAvaliaLikes(this.user.username).subscribe(response => {
      this.userLikes = response;
    })
  }

  removerLike(avalialike:AvaliaLike){

       this.midiaService.removeLike(avalialike).subscribe(response => {
        this.getAvaliaLikes();
    })
  }

  aceitar(relacionamento:Relacionamento){

    this.relacionamentoService.aceitarConvite(relacionamento).subscribe(response => {
      this.ngOnInit();
    })
  }

  recusar(relacionamento:Relacionamento){
    this.relacionamentoService.recusarConvite(relacionamento).subscribe(response => {
      this.ngOnInit();
    })
  }


}
