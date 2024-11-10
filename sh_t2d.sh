#!/bin/bash
# Time(s) for 360 deg with speed x 
echo "turn table test shell"

# Array holding times for each speed setting (indexed by speed - 1)
time_arr=(42 29 22 18 15 13 12 11 10 9)

# Initializations
margin_time=0.5
IP="192.168.219.105"
PORT="9138"
cmd="./t2d $IP $PORT"

# Number of rotations and speed value
count=5
deg=360
speed_val=1  # You can change this as needed (1 to 10)
echo "Running command: $cmd with speed $speed_val"
echo "$cmd n deg_spd $speed_val"
echo "$cmd n deg_apply"

# Calculate time for 360 degrees based on speed
s_time=$(echo "${time_arr[$((speed_val - 1))]} * ($deg / 360)" | bc -l)

# Run the loop for count rotations
while [ $count -ge 1 ]
do
   echo "Rotation count: $count"
   echo "Turning table to 360 degrees"
   
   # Execute command to rotate to 360 degrees
   $cmd n deg 360
   $cmd n deg_apply
   sleep $s_time  # Wait until the table completes 360 degrees
   
   echo "Turning table to 0 degrees"
   
   # Execute command to rotate back to 0 degrees
   $cmd n deg 0
   $cmd n deg_apply
   sleep $s_time  # Wait until the table completes 0 degrees
   
   # Decrement count and repeat the process
   count=$((count - 1))
done


### Sample 2

# Duration between direction changes
duration=300 #seconds

# Repeat one direction, then change direction
echo "Running command: $cmd with speed $speed_val"
echo "$cmd n rpt 1"
echo "$cmd n rpt_dir 0"
echo "$cmd n rpt_apply"
sleep $duration  # Wait for the action to complete
$cmd n rpt_dir 1
$cmd n rpt_apply
sleep $duration  # Wait for the action to complete
$cmd n rpt_dir 2
$cmd n rpt_apply
sleep $duration  # Wait for the action to complete

# Stop the repetition
$cmd n rpt 0
$cmd n rpt_apply

echo "Stop"

echo "Test complete!"

