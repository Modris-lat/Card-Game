import React from "react";
import {Box, Typography} from "@material-ui/core";
import {DisplayCards} from "./index";

export const PlayerHand = (props: any) => {
    return (
        <Box>
            <Typography>{props.name}</Typography>
            <DisplayCards cards={props.cards} />
        </Box>
    )
}