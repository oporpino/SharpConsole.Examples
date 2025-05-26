.PHONY: run build clean

# Default target
all: build run

# Build the container
build:
	docker compose build

# Clean up containers and volumes
clean:
	docker compose down -v

# Run the container
run.simple:
	docker compose run --rm sharpconsole.simple
