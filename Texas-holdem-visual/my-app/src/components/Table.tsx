import React from "react";
import {Box, Typography} from "@material-ui/core";

export const Table = (props: any) => {
    return (
        <Box>
            <Typography variant="h6">Cards on table</Typography>
            <Typography>{props.cards}</Typography>
        </Box>
    )
}