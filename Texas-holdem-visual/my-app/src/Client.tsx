import axios from "axios";

export const Clients = {
    adminClient : axios.create({
        baseURL: "http://localhost:8090/api/cardgame/input"
    })
}