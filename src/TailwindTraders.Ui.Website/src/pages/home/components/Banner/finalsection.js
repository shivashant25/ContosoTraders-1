import React from 'react'

import { Grid } from '@material-ui/core';
import Button from '@material-ui/core/Button';

const Finalsection = () => {
  return (
    <div className='final-section-container'>
      <Grid container className='grid-container'>
        <Grid item xs={6}>
        </Grid>
        <Grid item xs={6}>
          <div className='content-section'>
            <h1>Play more, wait less</h1>
            <p>A streamlined dashboard designed to get you into the games and entertainment you love quickly.</p>
            <Button className='start-btn' variant="outlined">Start Shopping</Button>
            </div>
        </Grid>
      </Grid>
    </div>
  )
}

export default Finalsection