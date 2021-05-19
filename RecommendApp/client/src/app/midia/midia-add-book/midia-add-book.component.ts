import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MidiaService } from 'src/app/_services/midia.service';


@Component({
  selector: 'app-midia-add-book',
  templateUrl: './midia-add-book.component.html',
  styleUrls: ['./midia-add-book.component.css']
})
export class MidiaAddBookComponent implements OnInit {


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
      editora: ['', Validators.required],
      titulo: ['', Validators.required],
      pais: ['', Validators.required],
      ano: ['', Validators.required],
    })
  }

  addMidia() {
    this.midiaService.setLivro(this.registerForm.value).subscribe(response => {
      this.router.navigateByUrl('/midias');
    }, error => {
      this.validationErrors = error;
    })
  }

  cancel() {
    this.router.navigateByUrl('/midias');
  }

}
