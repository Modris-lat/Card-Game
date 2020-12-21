import { AxiosResponse } from "axios";
import { action, IObservableArray, makeObservable, observable, runInAction } from "mobx";
import {Client} from "../Client";
import {Hand} from "./hand";
import {HandValuesRequest} from "./handValuesRequest";

export default class GetHandValues {
    constructor(){
        makeObservable(this);
    }
    hands: IObservableArray<Hand> = observable([]);
    @observable state = 'pending'
    @observable hand: Hand = {
        cards: [],
        handValue: 0,
        handValueType: ""
    }
    @action
    loadData = async (request: HandValuesRequest) => {
        try {
            const response = await this.get(request);
            const hands = response.data;
            console.log(hands);
            runInAction(() => {
                this.state = "done";
                this.hands.replace(hands)
            })
        } catch(error) {
            runInAction(() => {
                this.state = "error"
            })
        }
    }
    get = async(request: HandValuesRequest): Promise<AxiosResponse<Hand[]>> => {
        return await Client.defaultClient.post("", request);
    }
}