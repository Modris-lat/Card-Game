export class HandValuesRequest{
    table: string;
    hands: string[];
    constructor(table: string, hands: string[]){
        this.table = table;
        this.hands = hands;
    }
}