import { Integrante } from "./integrante.";


export interface Midia {
    id: string;
    username:string;
    titulo: string;
    photoUrl: string;
    pais: string;
    ano:number;
    tipo: number;
    lancamento:Date;
    likes:number;
    avaliado: boolean;
    integrantes: Integrante[];
}