dotnet tool install -g dotnet-fsharplint
# I'm not 100% sure what the canonical approach is when it comes
# to linting dotnet projects, but if we restore it's possible to pass
# in a project file to the linter.
dotnet restore

dotnet-fsharplint lint $@