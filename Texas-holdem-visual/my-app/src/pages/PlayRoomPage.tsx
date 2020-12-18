import React, {useState} from "react";
import { Box, Typography, Button, Avatar, Grid } from '@material-ui/core';
import { Hands } from "../components/Hands";
import { Table } from "../components/Table";
import { makeStyles } from '@material-ui/core/styles';

export const PlayRoomPage = () => {
    const classes = useStyles();
    const deck: string[] = [
        "2s", "2h", "2d", "2c", "3s", "3h", "3d", "3c", "4s", "4h", "4d", "4c",
        "5s", "5h", "5d", "5c", "6s", "6h", "6d", "6c", "7s", "7h", "7d", "7c",
        "8s", "8h", "8d", "8c", "9s", "9h", "9d", "9c", "Ts", "Th", "Td", "Tc",
        "Js", "Jh", "Jd", "Jc", "Qs", "Qh", "Qd", "Qc", "Ks", "Kh", "Kd", "Kc",
        "As", "Ah", "Ad", "Ac"
    ]
    const playerCount:number = 9;
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
            <Typography variant="h6">Cards deck</Typography>
            <Grid 
            container 
            direction="row">
                {otherCards.map((card, i)=>{
                return (
                <Grid key={i}>
                    <Avatar variant="square"
                     src={`/images/pngcards/c${card}.png`}
                      alt={card}
                      className={classes.size}/>
                </Grid>
                )
            })}</Grid>
            <Button variant="contained"
            onClick={set}>
                Go
                </Button>
            <Table cards={tableCards}/>
            <Hands cards={playerCards}/>
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