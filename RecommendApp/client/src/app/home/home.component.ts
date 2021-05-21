import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AccountService } from '../_services/account.service';
import { Avaliacao } from '../_models/avaliacao';
import { ToastrService } from 'ngx-toastr';
import { MidiaService } from '../_services/midia.service';
import { take } from 'rxjs/operators';
import { User } from '../_models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  avaliacaoList: Avaliacao [];
  user: User;

  constructor(public accountService:AccountService, private midiaService: MidiaService
    ,private toastr: ToastrService) {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);

   }

  ngOnInit(): void {
   this. getAvaliacoes();
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

}
