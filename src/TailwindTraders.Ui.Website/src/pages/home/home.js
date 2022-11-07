import React, { useEffect, useState } from "react";

import { Hero, Popular } from "./components";
import ChatBubble from './components/chatBubble/chatBubble';
import { ConfigService } from './../../services'
import Slider from "./components/slider/slider";
import Banner from "./components/Banner/banner";
import Gridsection from "./components/Banner/gridsection";
import Finalsection from "./components/Banner/finalsection";
const Home = ({ recommendedProducts, popularProducts, loggedIn }) => {
    const [customerSupportEnabled, setCustomerSupportEnabled] = useState(false);
    useEffect(() => {
        async function loadSettings() {
            await ConfigService.loadSettings();
            setCustomerSupportEnabled(ConfigService._customerSupportEnabled);
        }
        loadSettings();
    },[])
    return (
        <div className="home">
            <Hero />
            <Slider />
            <Banner />
            <Gridsection />
            <Finalsection />
            {/* <Recommended recommendedProductsData={recommendedProducts} loggedIn={loggedIn} /> */}
            {/* <Getapp /> */}
            {loggedIn && <Popular popularProductsData={popularProducts} />} 
            { customerSupportEnabled && <ChatBubble />}
        </div>
    );
};

export default Home;