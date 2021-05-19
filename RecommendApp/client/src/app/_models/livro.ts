export interface Livro {
    id: number;
    username:string;
    titulo: string;
    photoUrl: string;
    pais: string;
    ano:number;
    tipo: number;
    editora: string;
    lancamento:Date;
    autorDto: object[];
}