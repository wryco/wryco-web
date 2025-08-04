

Details:

- 50 workers, no rate limit, 60s duration, HTTP/1, 32 cpus cores, fully saturated host CPU
- API calls userService::test which calls User::FindAll which returns empty set from `SELECT * FROM Users`

```
root@9c4a92b04337:/go# hey -z 1m https://wryco_backend

Summary:
  Total:        60.0038 secs
  Slowest:      0.0243 secs
  Fastest:      0.0006 secs
  Average:      0.0030 secs
  Requests/sec: 18924.5260
  

Response time histogram:
  0.001 [1]     |
  0.003 [764553]        |■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
  0.005 [211708]        |■■■■■■■■■■■
  0.008 [19369] |■
  0.010 [3562]  |
  0.012 [643]   |
  0.015 [81]    |
  0.017 [34]    |
  0.020 [35]    |
  0.022 [7]     |
  0.024 [7]     |


Latency distribution:
  10% in 0.0017 secs
  25% in 0.0020 secs
  50% in 0.0024 secs
  75% in 0.0030 secs
  90% in 0.0038 secs
  95% in 0.0045 secs
  99% in 0.0067 secs

Details (average, fastest, slowest):
  DNS+dialup:   0.0000 secs, 0.0006 secs, 0.0243 secs
  DNS-lookup:   0.0000 secs, 0.0000 secs, 0.0097 secs
  req write:    0.0000 secs, 0.0000 secs, 0.0140 secs
  resp wait:    0.0029 secs, 0.0006 secs, 0.0192 secs
  resp read:    0.0000 secs, 0.0000 secs, 0.0102 secs

Status code distribution:
  [200] 1000000 responses
```
