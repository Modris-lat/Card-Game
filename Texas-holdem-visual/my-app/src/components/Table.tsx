import React from "react";
import {Box, Typography, Grid, Avatar} from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

export const Table = (props: any) => {
    const classes = useStyles();
    return (
        <Box>
            <Typography variant="h6">Cards on table</Typography>
            <Grid container direction="row">{props.cards.map((card:string, i:number)=>{
                return (
                <Grid key={i}>
                    <Avatar variant="square" 
                    src={`/images/pngcards/c${card}.png`} 
                    alt={card}
                    className={classes.size}/>
                </Grid>
                )
            })}</Grid>
        </Box>
    )
}
const useStyles = makeStyles((theme) => ({
    size: {
        height: 65,
        width: 45,
        border: "solid",
        borderColor: "black",
        borderWidth: "0.5px",
        margin: "1px"
    }
  }));