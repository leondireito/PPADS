import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/_models/member';
import { MembersService } from 'src/app/_services/members.service';
import { Observable } from 'rxjs';
import { Pagination } from 'src/app/_models/pagination';
import { UserParams } from 'src/app/_models/userParams';
import { AccountService } from 'src/app/_services/account.service';
import { take } from 'rxjs/operators';
import { User } from 'src/app/_models/user';
import { Midia } from 'src/app/_models/midia';
import { MidiaService } from 'src/app/_services/midia.service';

@Component({
  selector: 'app-midia-list',
  templateUrl: './midia-list.component.html',
  styleUrls: ['./midia-list.component.css']
})
export class MidiaListComponent implements OnInit {

  members: Member[];
  midias: Midia[];
  pagination: Pagination;
  userParams: UserParams;
  user: User;
  

  constructor(private midiaService: MidiaService, private memberService: MembersService) {
    this.userParams = this.memberService.getUserParams();
  }

  ngOnInit(): void {
    this.loadMidias();
  }

  loadMidias() {
    this.memberService.setUserParams(this.userParams);
    this.midiaService.getMidias(this.userParams).subscribe(response => {
      this.midias = response.result;
      this.pagination = response.pagination;

      console.log(this.midias);
    })

   
  }

  resetFilters() {
    this.userParams = this.memberService.resetUserParams();
    this.loadMidias();
  }

  pageChanged(event: any) {
    this.userParams.pageNumber = event.page;
    this.memberService.setUserParams(this.userParams);
    this.loadMidias();
  }
}


