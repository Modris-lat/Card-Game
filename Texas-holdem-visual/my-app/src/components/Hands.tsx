import React from "react";
import {Box, Grid, Typography} from "@material-ui/core";
import { PlayerHand } from "./PlayerHand";
import {HandValuesRequest} from "../api/handValuesRequest";
import { HandValues } from ".";

export const Hands = (props: any) => {
    const cards: string[] = props.cards;
    const player1Cards: string[] = [];
    const hands: string[] = [];
    const table = props.table.join('');
    let player1HandValue = 0;
    if(cards.length > 0){
        player1Cards.push(cards[0]);
        player1Cards.push(cards[1]);
        hands.push(cards[0] + cards[1]);
    }
    const player2Cards: string[] = [];
    let player2HandValue = 0;
    if(cards.length > 2){
        player2Cards.push(cards[2]);
        player2Cards.push(cards[3]);
        hands.push(cards[2] + cards[3]);
    }
    const player3Cards: string[] = [];
    let player3HandValue = 0;
    if(cards.length > 4){
        player3Cards.push(cards[4]);
        player3Cards.push(cards[5]);
        hands.push(cards[4] + cards[5]);
    }
    const player4Cards: string[] = [];
    let player4HandValue = 0;
    if(cards.length > 6){
        player4Cards.push(cards[6]);
        player4Cards.push(cards[7]);
        hands.push(cards[6] + cards[7]);
    }
    const player5Cards: string[] = [];
    let player5HandValue = 0;
    if(cards.length > 8){
        player5Cards.push(cards[8]);
        player5Cards.push(cards[9]);
        hands.push(cards[8] + cards[9]);
    }
    const player6Cards: string[] = [];
    let player6HandValue = 0;
    if(cards.length > 10){
        player6Cards.push(cards[10]);
        player6Cards.push(cards[11]);
        hands.push(cards[10] + cards[11]);
    }
    const player7Cards: string[] = [];
    let player7HandValue = 0;
    if(cards.length > 12){
        player7Cards.push(cards[12]);
        player7Cards.push(cards[13]);
        hands.push(cards[12] + cards[13]);
    }
    const player8Cards: string[] = [];
    let player8HandValue = 0;
    if(cards.length > 14){
        player8Cards.push(cards[14]);
        player8Cards.push(cards[15]);
        hands.push(cards[14] + cards[15]);
    }
    const player9Cards: string[] = [];
    let player9HandValue = 0;
    if(cards.length > 16){
        player9Cards.push(cards[16]);
        player9Cards.push(cards[17]);
        hands.push(cards[16] + cards[17]);
    }
    const request = new HandValuesRequest(table, hands);
    return (
        <Box>
            <Typography variant="h6">Cards on hands</Typography>
            <Grid container>
                <PlayerHand cards={player1Cards} name="Player1" value={player1HandValue}/>
                <PlayerHand cards={player2Cards} name="Player2" value={player2HandValue}/>
                <PlayerHand cards={player3Cards} name="Player3" value={player3HandValue}/>
                <PlayerHand cards={player4Cards} name="Player4" value={player4HandValue}/>
                <PlayerHand cards={player5Cards} name="Player5" value={player5HandValue}/>
                <PlayerHand cards={player6Cards} name="Player6" value={player6HandValue}/>
                <PlayerHand cards={player7Cards} name="Player7" value={player7HandValue}/>
                <PlayerHand cards={player8Cards} name="Player8" value={player8HandValue}/>
                <PlayerHand cards={player9Cards} name="Player9" value={player9HandValue}/>
            </Grid>
            <HandValues request={request} />
        </Box>
    )
}