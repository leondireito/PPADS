import { User } from './user';

export class UserParams {
    gender: string;
    minAge = 18;
    maxAge = 99;
    pageNumber = 1;
    pageSize = 7;
    username:string= '';
    name:string= '';
    midiaTitulo:string = '';
    midiaTipo:string ='3';
    orderBy = 'lastActive';
    avaliado = 'true';

    constructor(user: User) {
        this.gender = user.gender === 'female' ? 'male' : 'female';
    }
}