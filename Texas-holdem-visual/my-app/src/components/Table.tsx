import React from "react";
import {Box, Typography} from "@material-ui/core";
import {DisplayCards} from "./index";
import { makeStyles } from '@material-ui/core/styles';

export const Table = (props: any) => {
    const classes = useStyles();
    return (
        <Box className = {classes.container}>
            <DisplayCards cards={props.table} />
        </Box>
    )
}
const useStyles = makeStyles(() => ({
    container: {
        border: "solid",
        borderWidth: "15px",
        borderTopLeftRadius: "180px 50%",
        borderBottomLeftRadius: "180px 50%",
        borderBottomRightRadius: "180px 50%",
        borderTopRightRadius: "180px 50%",
        background: "#017525",
        width: "1000px",
        height: "500px",
        display: "flex",
        justifyContent: "center",
        alignItems: "center"
    }
  }));