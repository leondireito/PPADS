import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
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
  integrantes: FormArray;

  
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
      integrantes: this.fb.array([ this.crialemento() ])
    })
  }

  crialemento(): FormGroup {
    return this.fb.group({
      nome: '',
    });
  }

  addElemento(): void {
    this.integrantes = this.registerForm.get('integrantes') as FormArray;
    this.integrantes.push(this.crialemento());
  }

  removeElemento(i:number) {
    this.integrantes.removeAt(i);
  }

  addMidia() {
    this.midiaService.setLivro(this.registerForm.value).subscribe(response => {
      this.toastr.success('Livo adicionado');
      this.registerForm.reset();
    }, error => {
      this.validationErrors = error;
    })
  }

  cancel() {
    this.registerForm.reset();
  }

}
