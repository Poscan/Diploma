export interface IConference {
    id: number;
    name: string;
    organisationName: string;
    description: string;
    pictureUrl: string;
    countParticipants: number;
}

export default class Conference {
    constructor(options: IConference = {
        id: 0,
        name: "",
        organisationName: "Сургутский государственный университет",
        description: "",
        pictureUrl: "",
        countParticipants: 0}
    ) {
        this.id = options.id;
        this.name = options.name;
        this.organisationName = "Сургутский государственный университет";
        this.description = options.description;
        this.pictureUrl = options.pictureUrl ? options.pictureUrl : "event.png";
        this.countParticipants = options.countParticipants;
    }
  
    id: number;
    name: string;
    organisationName: string;
    description: string;
    pictureUrl: string;
    countParticipants: number;
  }