import React from "react";
import {Box, Typography} from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

export const TableTitle = () => {
    const classes = useStyles();
    return (
        <Box className={classes.container}>
            <Typography variant="h3" className={classes.text}>TEXAS HOLD'M POKER</Typography>
        </Box>
    )
};
const useStyles = makeStyles(() => ({
    text:{
        color: "white",
        fontWeight: "bold"
    },
    container: {
        marging: "200px"
    }
}));