export interface Filme {
    id: number;
    username:string;
    diretor: string;
    titulo: string;
    photoUrl: string;
    pais: string;
    ano:number;
    tipo: number;
    lancamento:Date;
    elencosDto: object[];
}