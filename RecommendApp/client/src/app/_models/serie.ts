export interface Serie {
    id: number;
    username:string;
    diretor: string;
    temporadas: string;
    titulo: string;
    photoUrl: string;
    pais: string;
    ano:number;
    tipo: number;
    lancamento:Date;
    elencosDto: object[];
}