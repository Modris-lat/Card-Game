import React from "react";
import {Box, Grid, Typography} from "@material-ui/core";
import { PlayerHand } from "./PlayerHand";
import { makeStyles } from '@material-ui/core/styles';

export const Hands = (props: any) => {
    const classes = useStyles();
    const cards: string[] = props.cards;
    const player1Cards: string[] = [];
    if(cards.length > 0){
        player1Cards.push(cards[0]);
        player1Cards.push(cards[1])
    }
    const player2Cards: string[] = [];
    if(cards.length > 2){
        player2Cards.push(cards[2]);
        player2Cards.push(cards[3])
    }
    const player3Cards: string[] = [];
    if(cards.length > 4){
        player3Cards.push(cards[4]);
        player3Cards.push(cards[5])
    }
    const player4Cards: string[] = [];
    if(cards.length > 6){
        player4Cards.push(cards[6]);
        player4Cards.push(cards[7])
    }
    const player5Cards: string[] = [];
    if(cards.length > 8){
        player5Cards.push(cards[8]);
        player5Cards.push(cards[9])
    }
    const player6Cards: string[] = [];
    if(cards.length > 10){
        player6Cards.push(cards[10]);
        player6Cards.push(cards[11])
    }
    const player7Cards: string[] = [];
    if(cards.length > 12){
        player7Cards.push(cards[12]);
        player7Cards.push(cards[13])
    }
    const player8Cards: string[] = [];
    if(cards.length > 14){
        player8Cards.push(cards[14]);
        player8Cards.push(cards[15])
    }
    const player9Cards: string[] = [];
    if(cards.length > 16){
        player9Cards.push(cards[16]);
        player9Cards.push(cards[17])
    }
    return (
        <Box>
            <Typography variant="h6">Cards on hands</Typography>
            <Grid container>
                <PlayerHand cards={player1Cards} name="player1"/>
                <PlayerHand cards={player2Cards} name="player2"/>
                <PlayerHand cards={player3Cards} name="player3"/>
                <PlayerHand cards={player4Cards} name="player4"/>
                <PlayerHand cards={player5Cards} name="player5"/>
                <PlayerHand cards={player6Cards} name="player6"/>
                <PlayerHand cards={player7Cards} name="player7"/>
                <PlayerHand cards={player8Cards} name="player8"/>
                <PlayerHand cards={player9Cards} name="player9"/>
            </Grid>
        </Box>
    )
}
const useStyles = makeStyles((theme) => ({
    container: {
        margin: "10px"
    }
  }));