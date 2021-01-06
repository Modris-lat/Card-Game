import React from "react";
import {Box} from "@material-ui/core";
import {DisplayCards} from "./index";
import { makeStyles } from '@material-ui/core/styles';

export const Table = (props: any) => {
    const classes = useStyles();
    return (
        <Box className={classes.tableBorder}>
            <Box className = {classes.table}>
                <Box className = {classes.tableCards}>
                    <DisplayCards cards={props.table} />
                </Box>
            </Box>
        </Box>
    )
};
const useStyles = makeStyles(() => ({
    table: {
        border: "solid black 2px",
        borderTopLeftRadius: "200px 50%",
        borderBottomLeftRadius: "200px 50%",
        borderBottomRightRadius: "200px 50%",
        borderTopRightRadius: "200px 50%",
        backgroundImage: "url(/images/table-background.jpg)",
        backgroundRepeat: "no-repeat",
        backgroundSize: "100%",
        width: "850px",
        height: "400px",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        margin: "auto"
    },
    tableCards: {
        height: "100px",
        width: "300px",
        margin: "auto",
        padding: "5px",
        display: "flex",
        alignItems: "center"
        
    },
    tableBorder:{
        backgroundImage: "url(/images/black-marble.jpg)",
        backgroundSize: "100%",
        width: "946px",
        height: "480px",
        display: "flex",
        verticalAlign: "center",
        borderTopLeftRadius: "215px 50%",
        borderBottomLeftRadius: "215px 50%",
        borderBottomRightRadius: "215px 50%",
        borderTopRightRadius: "215px 50%",
    }
  }));