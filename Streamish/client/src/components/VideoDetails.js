import React, { useEffect, useState } from "react";
import { ListGroup, ListGroupItem } from "reactstrap";
import { useParams } from "react-router-dom";
import Video from "./Video";
import { getVideo } from "../modules/videoManager";

const VideoDetails = () => {
  const [video, setVideo] = useState();
  const { id } = useParams();
  //allows use of the id in the url to be used

  useEffect(() => {
    getVideo(id).then(setVideo);
    // id from the url (ref line 10)
  }, []);

  if (!video) {
    return null;
  }

  return (
    <div className="container">
      <div className="row justify-content-center">
        <div className="col-sm-12 col-lg-6">
          <Video video={video} />
          <ListGroup>
            {video.comments.map((c) => (
              <ListGroupItem>{c.message}</ListGroupItem>
            ))}
          </ListGroup>
        </div>
      </div>
    </div>
  );
};

export default VideoDetails;
