using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;


namespace Microsoft.Samples.Kinect.KinectFusionExplorer
{
    //Las coordenadas de los 20 Joints
    public class JointsCoo
    {
        public CameraSpacePoint HeadCoo { get; set; }
        public CameraSpacePoint SpineShoulderCoo { get; set; }
        public CameraSpacePoint ShoulderLeftCoo { get; set; }
        public CameraSpacePoint ShoulderRightCoo { get; set; }
        public CameraSpacePoint ElbowRightCoo { get; set; }
        public CameraSpacePoint WristRightCoo { get; set; }
        public CameraSpacePoint HandRightCoo { get; set; }
        public CameraSpacePoint ElbowLeftCoo { get; set; }
        public CameraSpacePoint WristLeftCoo { get; set; }
        public CameraSpacePoint HandLeftCoo { get; set; }
        public CameraSpacePoint SpineBaseCoo { get; set; }
        public CameraSpacePoint HipRightCoo { get; set; }
        public CameraSpacePoint KneeRightCoo { get; set; }
        public CameraSpacePoint AnkleRightCoo { get; set; }
        public CameraSpacePoint FootRightCoo { get; set; }
        public CameraSpacePoint HipLeftCoo { get; set; }
        public CameraSpacePoint KneeLeftCoo { get; set; }
        public CameraSpacePoint AnkleLeftCoo { get; set; }
        public CameraSpacePoint FootLeftCoo { get; set; }
        public CameraSpacePoint SpineMidCoo { get; set; }
        public CameraSpacePoint NeckCoo { get; set; }
        public CameraSpacePoint HandTipLeftCoo { get; set; }
        public CameraSpacePoint HandTipRightCoo { get; set; }
        public CameraSpacePoint ThumbRightCoo { get; set; }
        public CameraSpacePoint ThumbLeftCoo { get; set; }

        public JointsCoo()
        {

            HeadCoo = new CameraSpacePoint();
            SpineShoulderCoo = new CameraSpacePoint();
            ShoulderLeftCoo = new CameraSpacePoint();
            ShoulderRightCoo = new CameraSpacePoint();
            ElbowRightCoo = new CameraSpacePoint();
            WristRightCoo = new CameraSpacePoint();
            HandRightCoo = new CameraSpacePoint();
            ElbowLeftCoo = new CameraSpacePoint();
            WristLeftCoo = new CameraSpacePoint();
            HandLeftCoo = new CameraSpacePoint();
            SpineBaseCoo = new CameraSpacePoint();
            HipRightCoo = new CameraSpacePoint();
            KneeRightCoo = new CameraSpacePoint();
            AnkleRightCoo = new CameraSpacePoint();
            FootRightCoo = new CameraSpacePoint();
            HipLeftCoo = new CameraSpacePoint();
            KneeLeftCoo = new CameraSpacePoint();
            AnkleLeftCoo = new CameraSpacePoint();
            FootLeftCoo = new CameraSpacePoint();
            SpineMidCoo = new CameraSpacePoint();
            HandTipLeftCoo = new CameraSpacePoint();
            HandTipRightCoo = new CameraSpacePoint();
            ThumbRightCoo = new CameraSpacePoint();
            ThumbLeftCoo = new CameraSpacePoint();
            NeckCoo = new CameraSpacePoint();

        }
              

    }
}
