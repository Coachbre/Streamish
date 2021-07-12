// controls which view is shown for each route (url)
import React from "react";
import { Switch, Route } from "react-router-dom";
//The Switch component is going to look at the url and render the first route that is a match.
import VideoList from "./VideoList";
import VideoForm from "./VideoForm";
import VideoDetails from "./VideoDetails";

const ApplicationViews = () => {
    // If a url matches the value of the path attribute, the children of that route will render
    //'exact' specifies the URL must match completely
    //':id' is a route param
    return (
        <Switch>
            <Route path="/" exact>
                <VideoList />
            </Route>

            <Route path="/videos/add">
                <VideoForm />
            </Route>

            <Route path="/videos/:id">
                <VideoDetails />
            </Route>
        </Switch>
    );
};

export default ApplicationViews;
