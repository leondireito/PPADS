import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup,FormArray, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MidiaService } from 'src/app/_services/midia.service';

@Component({
  selector: 'app-midia-add-serie',
  templateUrl: './midia-add-serie.component.html',
  styleUrls: ['./midia-add-serie.component.css']
})
export class MidiaAddSerieComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  registerForm: FormGroup;
  validationErrors: string[] = [];
  integrantes: FormArray;
  photoUrl:string;


  constructor(private midiaService: MidiaService, private toastr: ToastrService, 
    private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
    this.intitializeForm();
  }

  intitializeForm() {
    this.registerForm = this.fb.group({
      diretor: ['', Validators.required],
      temporadas: ['', Validators.required],
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

    console.log(this.registerForm.value);
    this.midiaService.setSerie(this.registerForm.value).subscribe(response => {
      this.router.navigateByUrl('/midias');
    }, error => {
      this.validationErrors = error;
    })
  }

  

  cancel() {
    this.router.navigateByUrl('/midias');
  }



}
