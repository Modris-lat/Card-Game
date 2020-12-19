import React from "react";
import { Grid, Avatar } from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

export const DisplayCards = (props: any) => {
    const classes = useStyles();
    return (
        <Grid container direction="row">
                {props.cards.map((card: string, i: number)=>{
                    return (
                        <Grid key={i}>
                            <Avatar variant="square"
                            alt={card} 
                            src={`/images/pngcards/c${card}.png`}
                            className={classes.size} />
                        </Grid>
                    )
                })}
            </Grid>
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