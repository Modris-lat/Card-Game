import { AxiosResponse } from "axios";
import { Hand } from "../components/Hand";
import { Clients } from "../Client";
import {HandValuesRequest} from "./HandValuesRequest";

export class GetHandValuesApi{
    getValues = async(requestValues: HandValuesRequest): Promise<AxiosResponse<Hand[]>> => {
        return await Clients.defaultClient.post('/input');
    }
}