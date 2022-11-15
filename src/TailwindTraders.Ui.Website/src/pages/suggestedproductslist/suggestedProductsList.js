import { Grid } from "@material-ui/core";
import React from "react";
import Breadcrump from "../../components/breadcrump";
import { ListAside, ListGrid } from "../list/components";

const SuggestedProductsList = (props) => {
    const [suggestedProductsList, setSuggestedProductsList] = React.useState(null);
    React.useEffect(() => {
        const suggestedProducts = props.location.state;
        setSuggestedProductsList(suggestedProducts.relatedProducts);
    }, [props.location.state]);
    return (
        <div className="list">
            <Breadcrump />
            {/* <OfferBanner /> */}
            <div className="list__content">
                <h6 className="mainHeading">Controllers</h6>
                <Grid container>
                    <Grid item xs={3}>
                        <ListAside
                            // onFilterChecked={onFilterChecked}
                            // typesList={typesList}
                            // brandsList={brandsList}
                        />
                    </Grid>
                    <Grid item xs={9}>
                        <ListGrid productsList={suggestedProductsList} />
                    </Grid>
                </Grid>
            </div>
            <hr className="m-0"/>
        </div>
    );
};

export default SuggestedProductsList;