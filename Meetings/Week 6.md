

agenda

- scenario 
	- indoor
	- outdoor
	- outdoor moving receiver
	- outdoor moving transmitter
- research question and methodology
	- research question
		- Can existing spoofing detection strategies be improved by incorporating aerial spoofing signals and using higher layer metrics?
			- At what altitude and distance does the aerial spoofing of signals have an effect on the accuracy of spoofing detection for fadeprint?
			- Can fadeprint be adopted to be used with higher layer metrics available through the android SDK? maybe?
	- methodology
		- reproduce results from fadeprint outdoor static NLoS, use as baseline
		- validate data when spoofing from drone
		- try with android sdk gps data and other model (CSI does not work with image recognition)
- LimeSDR
	- Existing works to read IRIDIUM GPS



Lime
- generation
	- https://github.com/osqzss/LimeGPS
- reading
	- https://github.com/muccc/gr-iridium


https://developer.android.com/develop/sensors-and-location/sensors/gnss


Questions
- drone spoofing also indoors?
	- is the sdr gain enough?
- reference for fadeprint?
	- ieee
	- other
- how can I verify that I am receiving IRIDIUM messages?
- Android GNSS
	- phase center offset?
	- AGC
	- ADR
- Use of the word Drone or UAV