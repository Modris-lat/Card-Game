import React from "react";
import {Box} from "@material-ui/core";
import {DisplayCards, TableTitle} from "./index";
import { makeStyles } from '@material-ui/core/styles';

export const Table = (props: any) => {
    const classes = useStyles();
    return (
        <Box className = {classes.table}>
            <Box>
                <Box className = {classes.tableCards}>
                    <DisplayCards cards={props.table} />
                </Box>
                <Box className = {classes.tableTitle}>
                    <TableTitle />
                </Box>
            </Box>
        </Box>
    )
};
const useStyles = makeStyles(() => ({
    table: {
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
    },
    tableCards: {
        border: "solid white 1px",
        height: "80px",
        width: "245px",
        margin: "20px",
        padding: "5px",
        display: "flex",
        alignItems: "center"
        
    },
    tableTitle: {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        margin: "20px"
    }
  }));