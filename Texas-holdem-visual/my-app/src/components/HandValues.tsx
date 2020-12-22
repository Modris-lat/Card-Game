import React, { useEffect, useState } from "react";
import { Box, Typography, Grid } from '@material-ui/core';
import {Client} from "../Client";
import { HandValuesRequest } from "../api/handValuesRequest";
import { Hand } from "../api/hand";

export const HandValues = ((props: any) => {
    const req: HandValuesRequest = props.request;
    const [values, setValues] = useState<Hand[]>([]);
    useEffect(() => {
        async function fetchData(){
            let request = await Client.defaultClient.post<Hand[]>("", req);
            console.log(request);
            if(request.status === 200){
                setValues([...request.data])
            }
            return request;
        }
        fetchData();
    }, [req]);
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
