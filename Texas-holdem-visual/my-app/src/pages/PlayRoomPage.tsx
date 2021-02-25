import React, {useState} from "react";
import { Box, Typography } from '@material-ui/core';
import {DisplayCards, Hands, Table, EventButton} from "../components/index";
import {deck} from "../deck";
import { makeStyles } from '@material-ui/core/styles';

export const PlayRoomPage = () => {
    const classes = useStyles();
    const playerCount:number = 8;
    const [round, setRound] = useState(0);
    const [otherCards, setOtherCards] = useState([...deck])
    const [tableCards, setTableCards] = useState<string[]>([]);
    const [playerCards, setPlayerCards] = useState<string[]>([]);
    const set = () => {
        if(round === 0){
            let resultOtherCards: string[] = [...otherCards];
            let resultPlayerCards: string [] = [];
            for(let i=0; i<playerCount*2; i++){
                let result: string = resultOtherCards[Math.floor(Math.random()*resultOtherCards.length)];
                resultPlayerCards.push(result);
                let index: number = resultOtherCards.indexOf(result);
                resultOtherCards.splice(index, 1);
            }
            setPlayerCards([...resultPlayerCards]);
            setOtherCards([...resultOtherCards]);
        }
        setRound(round+1);
        if(round === 1){
            let resultTableCards: string[] = [];
            let resultOtherCards: string[] = [...otherCards];
            for(let i=0; i<3; i++){
                let result: string = resultOtherCards[Math.floor(Math.random()*resultOtherCards.length)];
                resultTableCards.push(result);
                let index: number = resultOtherCards.indexOf(result);
                resultOtherCards.splice(index, 1);
            }
            setTableCards([...resultTableCards]);
            setOtherCards([...resultOtherCards]);
        }
        if(round === 2){
            let resultTableCards: string[] = [...tableCards];
            let resultOtherCards: string[] = [...otherCards];
            for(let i=0; i<1; i++){
                let result: string = resultOtherCards[Math.floor(Math.random()*resultOtherCards.length)];
                resultTableCards.push(result);
                let index: number = resultOtherCards.indexOf(result);
                resultOtherCards.splice(index, 1);
            }
            setTableCards([...resultTableCards]);
            setOtherCards([...resultOtherCards]);
        }
        if(round === 3){
            let resultTableCards: string[] = [...tableCards];
            let resultOtherCards: string[] = [...otherCards];
            for(let i=0; i<1; i++){
                let result: string = resultOtherCards[Math.floor(Math.random()*resultOtherCards.length)];
                resultTableCards.push(result);
                let index: number = resultOtherCards.indexOf(result);
                resultOtherCards.splice(index, 1);
            }
            setTableCards([...resultTableCards]);
            setOtherCards([...resultOtherCards]);
        }
    }
    return (
        <Box>
            <Typography variant="h5">PlayRoom round {round}</Typography>
            <EventButton set={set} />
            <Table table={tableCards} hands={playerCards}/>
            <Hands cards={playerCards} table={tableCards}/>
            <Typography variant="h6">Cards deck</Typography>
            <DisplayCards cards={otherCards} />
        </Box>
    )
}
const useStyles = makeStyles(() => ({
    
  }));