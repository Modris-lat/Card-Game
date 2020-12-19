import React from "react";
import {Box, Typography} from "@material-ui/core";
import {DisplayCards} from "./index";

export const Table = (props: any) => {
    return (
        <Box>
            <Typography variant="h6">Cards on table</Typography>
            <DisplayCards cards={props.cards} />
        </Box>
    )
}