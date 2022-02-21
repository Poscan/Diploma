import Client from "./Client";

export interface IConference {
    id: number;
    name: string;
    organisationName: string;
    description: string;
    pictureUrl: string;
    countParticipants: number;
    owner: Client;
}

export default class Conference {
    constructor(options: IConference = {
        id: 0,
        name: "",
        organisationName: "Сургутский государственный университет",
        description: "",
        pictureUrl: "",
        countParticipants: 0,
        owner: new Client()}
    ) {
        this.id = options.id;
        this.name = options.name;
        this.organisationName = "Сургутский государственный университет";
        this.description = options.description;
        this.pictureUrl = options.pictureUrl ? options.pictureUrl : "/event.png";
        this.countParticipants = options.countParticipants;
        this.owner = new Client(options.owner);
    }
  
    id: number;
    name: string;
    organisationName: string;
    description: string;
    pictureUrl: string;
    countParticipants: number;
    owner: Client;
  }