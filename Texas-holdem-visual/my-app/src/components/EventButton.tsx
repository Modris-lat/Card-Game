import React from "react";
import { Button } from '@material-ui/core';

export const EventButton = (props: any) => {
    return (
        <Button variant="contained"
        onClick={props.set}>
                Go
        </Button>
    )
}