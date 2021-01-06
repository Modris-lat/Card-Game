import React from "react";
import { Grid, Avatar, Box } from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

export const DisplayCards = (props: any) => {
    const classes = useStyles();
    return (
        <Box>
            <Grid container direction="row">
                {props.cards.map((card: string, i: number)=>{
                    return (
                        <Grid key={i}>
                            <Avatar variant="square"
                            alt={card} 
                            src={`/images/pngcards/c${card}.png`}
                            className={classes.cards} />
                        </Grid>
                    )
                })}
            </Grid>
        </Box>
    )
}
const useStyles = makeStyles(() => ({
    container: {
        margin: "auto"
    },
    cards: {
        height: 80,
        width: 55,
        border: "solid",
        borderColor: "black",
        borderWidth: "0.5px",
        margin: "1px",
        backgroundColor: "white"
    }
  }));