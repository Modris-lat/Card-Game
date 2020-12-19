import { AxiosResponse } from "axios";
import {Client} from "../Client";
import {Hand, HandValuesRequest} from "./index";

export const getHandValues = async(request: HandValuesRequest): Promise<AxiosResponse<Hand[]>> => {
    return await Client.defaultClient.post("", request);
}