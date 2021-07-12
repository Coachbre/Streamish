import React, { useEffect, useState } from "react";
import Video from './Video';
import { getAllVideos } from "../modules/videoManager";

const VideoList = () => {
  const [videos, setVideos] = useState([]);

  const getVideos = () => {
    getAllVideos().then(videos => setVideos(videos));
  };

  useEffect(() => {
    getVideos();
  }, []);

  return (
    <div className="container">
      <div className="row justify-content-center">
        {videos.map((video) => (
          <Video video={video} key={video.id} />
        ))}
      </div>
    </div>
  );
};

export default VideoList;


//When the component loads, it will call the getAllVideos function,
// set the state of the videos array and re-render to display a list of video titles.