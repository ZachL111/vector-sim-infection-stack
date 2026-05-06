# Review Journal

I treated `vector-sim-infection-stack` as a project where the smallest useful behavior should still be inspectable.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 172, lane `ship`
- `stress`: `state drift`, score 121, lane `watch`
- `edge`: `review cost`, score 171, lane `ship`
- `recovery`: `decision risk`, score 224, lane `ship`
- `stale`: `input pressure`, score 223, lane `ship`

## Note

The repository should be understandable without pretending it is larger than it is.
