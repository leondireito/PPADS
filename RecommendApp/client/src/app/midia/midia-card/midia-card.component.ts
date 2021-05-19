import { Component, OnInit, Input } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Member } from 'src/app/_models/member';
import { Midia } from 'src/app/_models/midia';
import { MembersService } from 'src/app/_services/members.service';
import { MidiaService } from 'src/app/_services/midia.service';
import { PresenceService } from 'src/app/_services/presence.service';


@Component({
  selector: 'app-midia-card',
  templateUrl: './midia-card.component.html',
  styleUrls: ['./midia-card.component.css']
})
export class MidiaCardComponent implements OnInit {

  @Input() midia: Midia;

  constructor(private midiaService: MidiaService, memberService: MembersService,private toastr: ToastrService, 
    public presence: PresenceService) { }

  ngOnInit(): void {
  }

  addLike(midia: Midia) {
    this.midiaService.addLike(midia.username).subscribe(() => {
      this.toastr.success('Voce deu um like para ' + midia.username);
    })
  }

}
