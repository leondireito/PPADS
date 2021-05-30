import { Component, OnInit, Input } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Member } from 'src/app/_models/member';
import { Midia } from 'src/app/_models/midia';
import { MembersService } from 'src/app/_services/members.service';
import { MidiaService } from 'src/app/_services/midia.service';


@Component({
  selector: 'app-midia-card',
  templateUrl: './midia-card.component.html',
  styleUrls: ['./midia-card.component.css']
})
export class MidiaCardComponent implements OnInit {

  @Input() midia: Midia;

  constructor(private midiaService: MidiaService, memberService: MembersService,private toastr: ToastrService ) { }

  ngOnInit(): void {
  }

  addLike(midia: Midia) {
   
  }

}
