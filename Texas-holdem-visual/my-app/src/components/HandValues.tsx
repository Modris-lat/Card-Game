import React, { useEffect, useState } from "react";
import { Box, Typography, Grid } from '@material-ui/core';
import {Client} from "../Client";
import { HandValuesRequest } from "../api/handValuesRequest";
import { Hand } from "../api/hand";

export const HandValues = ((props: any) => {
    const request: HandValuesRequest = props.request;
    const [values, setValues] = useState<Hand[]>([]);
    useEffect(() => {
        async function fetchData(){
            let response = await Client.defaultClient.post<Hand[]>("", request);
            if(response.status === 200){
                setValues([...response.data])
            }
            return response;
        }
        fetchData();
    }, [request]);
    return (
        <Box>
            <Grid container>{values.map((hand, i) => {
                return (
                    <Box key={i}>
                        <Typography>Cards {hand.hand.join('')}</Typography>
                        <Typography>Hand value {hand.handValue}</Typography>
                        <Typography>Value type {hand.handValueType}</Typography>
                    </Box>
                )
            })}</Grid>
        </Box>
    )
})
