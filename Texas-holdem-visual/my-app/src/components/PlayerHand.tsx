import React from "react";
import {Box, Typography} from "@material-ui/core";
import {DisplayCards} from "./index";
import { makeStyles } from '@material-ui/core/styles';

export const PlayerHand = (props: any) => {
    const classes = useStyles();
    return (
        <Box className={classes.container}>
            <Typography>{props.name}</Typography>
            <Typography>Hand value {props.value}</Typography>
            <DisplayCards cards={props.cards} />
        </Box>
    )
}
const useStyles = makeStyles((theme) => ({
    container: {
        margin: "5px"
    }
  }));