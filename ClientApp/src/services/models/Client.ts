export interface IClient {
    id: number;
    firstName: string;
    lastName: string;
    secondName: string;
}

export default class Client {
    constructor(options: IClient = {
        id: 0,
        firstName: "",
        lastName: "",
        secondName: ""}
    ) {
        this.id = options.id;
        this.firstName = options.firstName;
        this.lastName = options.lastName;
        this.secondName = options.secondName;
    }
  
    id: number;
    firstName: string;
    lastName: string;
    secondName: string;

    get fullName(): string {
        return [this.lastName, this.firstName, this.secondName].filter((x) => x).join(" "); 
    }
  }