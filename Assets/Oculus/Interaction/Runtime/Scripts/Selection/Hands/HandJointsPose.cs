/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using Oculus.Interaction.Input;
using UnityEngine;

namespace Oculus.Interaction
{
    /// <summary>
    /// Updates the transform to be the interpolated position
    /// of a series of joints in the associated IHand.
    /// </summary>
    public class HandJointsPose : MonoBehaviour
    {
        [SerializeField, Interface(typeof(IHand))]
        private UnityEngine.Object _hand;
        public IHand Hand { get; private set; }

        [System.Serializable]
        public struct WeightedJoint
        {
            public HandJointId handJointId;
            public float weight;
        }

        [SerializeField]
        private List<WeightedJoint> _weightedJoints;

        [SerializeField]
        private Vector3 _localPositionOffset;

        [SerializeField]
        private Quaternion _rotationOffset = Quaternion.identity;

        #region Properties

        public List<WeightedJoint> WeightedJoints
        {
            get
            {
                return _weightedJoints;
            }
            set
            {
                _weightedJoints = value;
            }
        }

        public Vector3 LocalPositionOffset
        {
            get
            {
                return _localPositionOffset;
            }
            set
            {
                _localPositionOffset = value;
            }
        }

        public Quaternion RotationOffset
        {
            get
            {
                return _rotationOffset;
            }
            set
            {
                _rotationOffset = value;
            }
        }

        #endregion

        protected bool _started = false;

        protected virtual void Awake()
        {
            Hand = _hand as IHand;
        }

        protected virtual void Start()
        {
            this.BeginStart(ref _started);
            this.AssertField(Hand, nameof(Hand));
            this.EndStart(ref _started);
        }

        protected virtual void OnEnable()
        {
            if (_started)
            {
                Hand.WhenHandUpdated += HandleHandUpdated;
            }
        }

        protected virtual void OnDisable()
        {
            if (_started)
            {
                Hand.WhenHandUpdated -= HandleHandUpdated;
            }
        }

        private void HandleHandUpdated()
        {
            Pose pose = Pose.identity;
            float accumulatedWeight = 0f;
            foreach (WeightedJoint weightedJoint in _weightedJoints)
            {
                if (!Hand.GetJointPose(weightedJoint.handJointId, out Pose jointPose))
                {
                    return;
                }

                float t = weightedJoint.weight / (accumulatedWeight + weightedJoint.weight);
                accumulatedWeight += weightedJoint.weight;
                pose.Lerp(jointPose, t);
            }

            Vector3 positionOffsetWithHandedness =
                (Hand.Handedness == Handedness.Left ? -1f : 1f) * _localPositionOffset;
            pose.position += _rotationOffset * pose.rotation *
                              positionOffsetWithHandedness * Hand.Scale;
            transform.SetPose(pose);
        }

        #region Inject

        public void InjectAllHandJoint(IHand hand)
        {
            InjectHand(hand);
        }

        public void InjectHand(IHand hand)
        {
            _hand = hand as UnityEngine.Object;
            Hand = hand;
        }

        #endregion;
    }
}
