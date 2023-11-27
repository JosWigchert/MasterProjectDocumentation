| Key point                    |                  DeepFi                  |                Acc & Eff                 |                 CSI-MIMO                 |                 Enc UAV                  |                   UAV                    | Spotr                                    |
| ---------------------------- |:----------------------------------------:|:----------------------------------------:|:----------------------------------------:|:----------------------------------------:|:----------------------------------------:| ---------------------------------------- |
| Indoor                       | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Localisation                 | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |
| Deep Learning                | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| CSI                          | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Fingerprinting               |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |
| WAPs                         |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| CFO                          |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| WIFI                         |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| FP dependant on HW specifics |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled >        |
| UAV                          |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> | <input type="checkbox" disabled>         |
| Safeguarding unauth access   |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> | <input type="checkbox" disabled>         |
| Encrypted channel            |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Outdoor                      |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |
| Extra HW                     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Intel 5300                   | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Probabilistic                |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| Temporal stability           |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled>         |
| No channel modeling          |         <input type="checkbox" >         |         <input type="checkbox" >         |         <input type="checkbox" >         |         <input type="checkbox" >         |         <input type="checkbox" >         | <input type="checkbox" disabled checked> |
| IQ samples                   |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |
| MVN                          |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     |     <input type="checkbox" disabled>     | <input type="checkbox" disabled checked> |
| no encryption                |                                          |                                          |                                          |                                          |                                          |                                          |


Abbreviations:
- **DL**: Deep Learning
- **CSI**: Channel State Information
- **CFO**: Channel Frequency Offset
- **Prob**: Probabilistic
- **Detr**: Deterministic
- **FP**: Fingerprinting
- **CPA**: Carrier Phase Alignment
- **CN0**: code-lock-detector
- **CLT**: carrier-lock-detector
- **CPA**: Carrier Phase Alignment
- **SSP**: Signal Spatial Correlation (using amplitude and doppler)
- **AGC**: Automatic gain control
- **FCDD**: Fully Convolutional Data Description
- **CPA**: Carrier Phase Alignment
- **CPA**: Carrier Phase Alignment
 (CN0) and  (CLT).

| Key points   | Fadeprint  |    Deepfi    | Acc& Eff |      CSI-MIMO      |   (enc) UAV   |      Spotr       | Handheld receivers |       Military Signals       |     |
| ------------ | ---------- |:------------:|:--------:|:------------------:|:-------------:|:----------------:|:------------------:|:----------------------------:| --- |
| Location     | I/O        |      I       |    na    |         I          |       O       |        O         |        I/O         |             I/O              |     |
| Encryption   | N          |      N       |    N     |         N          |       Y       |        N         |         N          |             N/Y              |     |
| Antenna      | S          |     S/M      |    S     |         M          |      NA       |        S         |         S          |              M               |     |
| Goal         | FP         | Localisation |    FP    |         FP         | Shield-Access |        FP        |         FP         |              FP              |     |
| Metric       | IQ samples |     CSI      | CSI/CFO  |        CSI         |      NA       | CPA / IQ samples |        SSP         |     AGC / CA code power      |     |
| Method       | DL(FCDD)   |      DL      |   Math   |     Prob/Detr      |    Crypto     |     CN0/CLT      |                    |      cross correlation       |     |
| Requirements |            |              |          |        Enc         |      Enc      |                  |      Movement      | Presence enc military signal |     |
| Tags         |            |              |          | Temporal Stability |      UAV      |                  |                    |                              |     |
