import { Grid } from "@material-ui/core";
import React from "react";



function Banner(props) {
  return (
    <section>
      <Grid className="BannerSection" container>
        <Grid item xs={6}>
          <div className="BannerHeading">
            {props.firstHeading}
          </div>
          <div className="BannerContent">
            {props.secondHeading}
          </div>
          <div className="BannerButtondiv">
            <button className="BannerButton">Start Shopping</button>
          </div>
        </Grid>
      </Grid>
    </section>
  );
}

export default Banner;