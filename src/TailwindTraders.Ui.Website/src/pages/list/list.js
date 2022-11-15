import { Grid } from "@material-ui/core";
import React from "react";
import { OfferBanner, ListGrid, ListAside } from "./components";
import Breadcrump  from "../../components/breadcrump";
import { withRouter } from "react-router-dom";

const List = ({ typesList, brandsList, onFilterChecked, productsList, loggedIn }) => {
    return (
        <div className="list">
            <Breadcrump />
            <OfferBanner />
            <div className="list__content">
                <h6 className="mainHeading">Controllers</h6>
                <Grid container>
                    <Grid item xs={3}>
                        <ListAside
                            onFilterChecked={onFilterChecked}
                            typesList={typesList}
                            brandsList={brandsList}
                        />
                    </Grid>
                    <Grid item xs={9}>
                        <ListGrid productsList={productsList} />
                    </Grid>
                </Grid>
            </div>
            <hr className="m-0"/>
        </div>
    );
};

export default withRouter(List);
