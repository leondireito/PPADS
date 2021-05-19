import { Photo } from './photo';

export interface Member {
    id: number;
    username: string;
    name: string;
    photoUrl: string;
    age: number;
    birthDate:Date;
    knownAs: string;
    created: Date;
    lastActive: Date;
    gender: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    state: string;
    country: string;
    photos: Photo[];
  }
  
