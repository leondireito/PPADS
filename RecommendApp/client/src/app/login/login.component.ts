import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  model: any = {}

  constructor(public accountService:AccountService, private router:Router,
    private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  login() {

    this.accountService.login(this.model).subscribe(response => {
    this.router.navigateByUrl("/members");
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
    
  }

 
  logiout() {
  
    this.accountService.logout();
    this.router.navigateByUrl("/");
  }

}
