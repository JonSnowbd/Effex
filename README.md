# What is Effex

Effex is a windows tool for compiling Monogame effects without using an MGCB file,
or without adding the new tool pipeline to your environment path.

Effex focuses on making this simple by enabling batch-compiling by
drag and drop or mass execute of .fx files if you have Effex associated with
.fx files.

# How should I use Effex?

Simply install from the releases section, and then associate .fx files with the binary.
Once you have done that, compiling a .fx file is as simple as double clicking it.

If you start Effex without a .fx file drop, you can view the main console which lets
you install the MGCB tooling that Effex uses under the hood.

# What do I need to use Effex?

You only need the C# Runtime installed (eg, you can use `dotnet` cli). Which naturally you
should already have considering this is for Monogame.

If you do not have the MGCB tooling installed when compiling, the main console will prompt
you and automatically install it for you(with your permission).

Concerning the automatic install, [the code related to it is very simple](https://github.com/JonSnowbd/Effex/blob/master/Effex/EffexConsole.cs#L14)
and will not prompt any security concerns.

# Download

Hit up the latest release [here](https://github.com/JonSnowbd/Effex/releases)