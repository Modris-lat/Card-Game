import React from "react";
import {Box, Typography} from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

export const TableTitle = () => {
    const classes = useStyles();
    return (
        <Box>
            <Typography variant="h5" className={classes.text}>TEXAS HOLD'EM POKER</Typography>
        </Box>
    )
};
const useStyles = makeStyles(() => ({
    text:{
        color: "rgba(255, 255, 0, 0.2)",
        fontWeight: "bold"
    }
}));