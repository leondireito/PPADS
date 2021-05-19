import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MidiaService } from 'src/app/_services/midia.service';


@Component({
  selector: 'app-midia-add-movie',
  templateUrl: './midia-add-movie.component.html',
  styleUrls: ['./midia-add-movie.component.css']
})
export class MidiaAddMovieComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();
  registerForm: FormGroup;
  validationErrors: string[] = [];

  
  constructor(private midiaService: MidiaService, private toastr: ToastrService, 
    private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.intitializeForm();
  }

  intitializeForm() {
    this.registerForm = this.fb.group({
      diretor: ['', Validators.required],
      titulo: ['', Validators.required],
      pais: ['', Validators.required],
      ano: ['', Validators.required],
      
    })
  }

  addMidia() {
    this.midiaService.setFilme(this.registerForm.value).subscribe(response => {
      this.router.navigateByUrl('/midias');
    }, error => {
      this.validationErrors = error;
    })
  }

  cancel() {
    this.router.navigateByUrl('/midias');
  }



}
